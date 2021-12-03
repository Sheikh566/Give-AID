import * as React from "react";
import PropTypes from "prop-types";
import { useRecordContext } from "react-admin";

const EventPosterField = (props) => {
  const { source, title } = props;
  const record = useRecordContext(props);
  const myStyle = {
    margin: "0.5rem",
    maxHeight: "10rem",
    opacity: .8
  };
  return (
    <div>
      <img
        src={require("./eventPosters/" + record[source]).default}
        alt={title}
        width="100px"
        style={myStyle}
      />
    </div>
  );
};

EventPosterField.propTypes = {
  label: PropTypes.string,
  record: PropTypes.object,
  source: PropTypes.string.isRequired,
};

export default EventPosterField;
