import React from "react";
import {
  List,
  Datagrid,
  TextField,
  DateField,
  EditButton,
  DeleteButton,
  ImageField,


} from "react-admin";
import EventPosterField from "./EventPosterField";

export default function EventsList(props) {
  
  return (
    <List {...props} pagination={false}>
      <Datagrid>
        <TextField source="id" label="ID" />
        <TextField source="event_title" label="Title" />
        <DateField source="event_date" label="Date" />
        <TextField source="event_description" label="Description" />
         <EventPosterField source="id" title="Poster" />
         <ImageField source="event_poster" title="Poster" />
        <EditButton basePath="/EVENTS" />
        <DeleteButton basePath="/EVENTS" />
      </Datagrid>
    </List>
  );
}
