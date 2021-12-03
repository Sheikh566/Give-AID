import React from 'react'
import { List, Datagrid, TextField, ChipField, NumberField, EditButton, DeleteButton } from 'react-admin'

export default function CausesList(props) {
    return (
      <List {...props}  pagination={false}>
          <Datagrid>
              <TextField source='id' label="ID"/>
              <ChipField source='cause_name' label="Cause Name" color='secondary'/>
              <NumberField source='cause_funds' label="Funds (IN PKR)"/>
              <EditButton basePath='/CAUSES' />
              <DeleteButton basePath='/CAUSES' />
          </Datagrid>
      </List>
    );
  }