import React from "react";
import { Create, SimpleForm, TextInput } from 'react-admin'

export default function AdminCreate(props) {
    return (
        <Create title="Create new admin" {...props}>
            <SimpleForm>
                <TextInput source='admin_fname' label='First Name'></TextInput>
                <TextInput source='admin_lname' label='Last Name'></TextInput>
                <TextInput source='admin_email' label='Email'></TextInput>
                <TextInput source='admin_password' label='Password'></TextInput>
            </SimpleForm>
        </Create>
    );
}