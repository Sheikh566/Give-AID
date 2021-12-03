import React from "react";
import {
  List,
  TextField,
  EditButton,
  DeleteButton,
  Datagrid
} 
from "react-admin";

export default function JobsList(props) {
    return (
      <List {...props} pagination={false}>
          <Datagrid>
              <TextField source='id' label="ID"/>
              <TextField source='job_title' label="Job Title"/>
              <TextField source='job_description' label="Description"/>
              <EditButton basePath='/jobs' />
              <DeleteButton basePath='/jobs' />
        </Datagrid>
      </List>
    );
  }