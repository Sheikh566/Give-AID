import React from 'react'
import { List, Datagrid, TextField, EmailField, EditButton, DeleteButton } from 'react-admin'

export default function AdminsList(props) {
    return (
      <List {...props}  pagination={false}>
          <Datagrid>
              <TextField source='id' label="ID"/>
              <TextField source='admin_fname' label="First Name"/>
              <TextField source='admin_lname' label="Last Name"/>
              <EmailField source='admin_email' label="Email"/>
              <TextField source='admin_password' label="Password"/>
              <EditButton basePath='/ADMINS' />
              <DeleteButton basePath='/ADMINS' />
          </Datagrid>
      </List>
    );
  }