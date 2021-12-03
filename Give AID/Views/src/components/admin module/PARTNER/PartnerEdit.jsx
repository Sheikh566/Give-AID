import React from "react";
import { Edit, ImageInput, SimpleForm, TextInput } from "react-admin";

export default function PartnerEdit(props) {
  return (
    <Edit title="Edit partner" {...props}>
      <SimpleForm>
        <TextInput source="id" label="ID" disabled />
        <TextInput source="partner_name" label="Partner Name" />
        <ImageInput source="partner_logo" label="Partner Logo" />
      </SimpleForm>
    </Edit>
  );
}
