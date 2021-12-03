import React from "react";
import { Edit, SimpleForm, TextInput, PasswordInput } from "react-admin";

export default function AdminEdit(props) {
  return (
    <Edit title="Edit the admin" {...props}>
      <SimpleForm>
        <TextInput source="id" label="ID" disabled />
        <TextInput source="admin_fname" label="First Name" />
        <TextInput source="admin_lname" label="Last Name" />
        <TextInput source="admin_email" label="Email" />
        <PasswordInput source="admin_password" label="Password" />
      </SimpleForm>
    </Edit>
  );
}