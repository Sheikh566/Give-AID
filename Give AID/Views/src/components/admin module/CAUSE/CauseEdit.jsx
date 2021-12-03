import React from "react";
import { Edit, SimpleForm, TextInput, NumberInput } from "react-admin";

export default function CauseEdit(props) {
  return (
    <Edit title="Edit the cause" {...props}>
      <SimpleForm>
        <TextInput source="id" label="ID" disabled />
        <TextInput source="cause_name" label="Cause Name" />
        <NumberInput source="cause_funds" label="Funds" />
      </SimpleForm>
    </Edit>
  );
}