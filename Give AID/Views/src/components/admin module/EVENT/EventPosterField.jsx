import React, { useState } from 'react';
import PropTypes from "prop-types";
import { useRecordContext } from 'ra-core';


const EventPosterField = (props) => {
  const [imgSrc, setImgSrc] = useState("");
  const { source, title } = props;
  const record = useRecordContext(props);
    fetch("https://localhost:44385/api/Events/getposter/"+record[source])
    .then(res => {
        res.json().then(data => setImgSrc(data))
      })
    .catch(err => console.log(err))

  const handleClick = (e) => {
    
  }
  const myStyle = {
    margin: "0.5rem",
    maxHeight: "10rem",
    opacity: .8
  };
  return (
    <div>
      <img
        src={imgSrc}
        alt={title}
        width="100px"
        style={myStyle}
        onClick={handleClick}
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
