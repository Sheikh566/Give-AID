import React from "react";
import {
  List,
  Datagrid,
  TextField,
  EmailField,
  EditButton,
  DeleteButton,
  // TextInput,
  // ReferenceInput,
  // SelectInput
} 
from "react-admin";

export default function UsersList(props) {
    // const postFilters = [
    // <TextInput source="q" label="Search" alwaysOn />,
    // <ReferenceInput source="id" label="User" reference="users" allowEmpty>
    //   <SelectInput optionText="name" />
    // </ReferenceInput>,
    // ];
    return (
      <List {...props} pagination={false}>
          <Datagrid>
              <TextField source='id' label="ID"/>
              <TextField source='user_fname' label="First Name"/>
              <TextField source='user_lname' label="Last Name"/>
              <EmailField source='user_email' label="Email"/>
              <TextField source='user_password' label="Password"/>
              <EditButton basePath='/users' />
              <DeleteButton basePath='/users' />
          </Datagrid>
      </List>
    );
  }