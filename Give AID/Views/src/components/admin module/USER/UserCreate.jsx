import React from "react";
import { Create, SimpleForm, TextInput, PasswordInput } from 'react-admin'

export default function UserCreate(props) {
    return (
        <Create title="Create a new user" {...props}>
            <SimpleForm>
                <TextInput source='user_fname' label='First Name'/>
                <TextInput source='user_lname' label='Last Name'/>
                <TextInput source='user_email' label='Email' type='email'/>
                <PasswordInput source='user_password' label='Password'/>
            </SimpleForm>
        </Create>
    );
}