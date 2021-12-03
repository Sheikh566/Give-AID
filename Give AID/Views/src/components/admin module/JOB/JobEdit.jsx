import React from "react";
import { Edit, SimpleForm, TextInput} from "react-admin";

export default function JobEdit(props) {
  return (
    <Edit title="Edit job info" {...props}>
      <SimpleForm>
        <TextInput source="id" label="ID" disabled />
        <TextInput source="job_title" label="Title" />
        <TextInput source="job_description" label="Description" />
      </SimpleForm>
    </Edit>
  );
}
