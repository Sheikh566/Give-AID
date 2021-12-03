import React from 'react'
import { List, Datagrid, TextField, ChipField, DateField, NumberField, ReferenceField, FunctionField } from 'react-admin'

export default function DonationsList(props) {
    return (
      <List {...props}  pagination={false}>
          <Datagrid>
              <TextField source='id' label="ID"/>
              <DateField source='donation_date' label="Donated At" showTime/>
              <ReferenceField label="User" source="user_id" reference="USERS">
                <FunctionField label="Name" render={record => `${record.user_fname} ${record.user_lname}`} />
              </ReferenceField>
              <ReferenceField label="Cause" source="cause_id" reference="CAUSES">
                <ChipField source="cause_name" color='secondary'/>
              </ReferenceField>
              <NumberField source='donation_amount'  label="Amount (IN PKR)"/>
          </Datagrid>
      </List>
    );
  }
  