import React from "react";
import { Edit, SimpleForm, TextInput, PasswordInput } from "react-admin";

export default function UserEdit(props) {
  return (
    <Edit title="Edit the user" {...props}>
      <SimpleForm>
        <TextInput source="id" label="ID" disabled />
        <TextInput source="user_fname" label="First Name" />
        <TextInput source="user_lname" label="Last Name" />
        <TextInput source="user_email" label="Email" />
        <PasswordInput source="user_password" label="Password" />
      </SimpleForm>
    </Edit>
  );
}
