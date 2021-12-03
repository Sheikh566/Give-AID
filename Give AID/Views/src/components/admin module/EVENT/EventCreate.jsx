import React from "react";
import { Create, SimpleForm, TextInput, DateInput, ImageInput } from 'react-admin'

export default function EventCreate(props) {
    return (
        <Create title="Create a new event" {...props}>
            <SimpleForm>
                <TextInput source='event_title' label='Event Title'/>
                <DateInput source='event_date' label='Date'/>
                <TextInput source='event_description' label='Description' multiline/>
                <ImageInput source='event_poster' label='Poster'/>
            </SimpleForm>
        </Create>
    );
}