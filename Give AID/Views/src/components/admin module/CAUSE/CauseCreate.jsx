import React from 'react'
import { Create, SimpleForm, TextInput, NumberInput } from 'react-admin'

export default function CauseCreate(props) {
    return (
        <Create title="Create a new cause" {...props}>
            <SimpleForm>
                <TextInput source='cause_name' label='Cause Name' />
                <NumberInput source='cause_funds' label='Starting Funds' />
            </SimpleForm>
        </Create>
    );
}