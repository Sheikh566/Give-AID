import React from "react";
import {
  List,
  TextField,
  EditButton,
  DeleteButton,
  Datagrid
} 
from "react-admin";
import PartnerLogoField from "./PartnerLogoField";

export default function JobsList(props) {
    return (
      <List {...props} pagination={false}>
          <Datagrid>
              <TextField source='id' label="ID"/>
              <TextField source='partner_name' label="Name"/>
              <PartnerLogoField source='partner_logo' />
              <EditButton basePath='/partners' />
              <DeleteButton basePath='/partners' />
        </Datagrid>
      </List>
    );
  }