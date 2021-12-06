import React from "react";
import { List, TextField, DateField, ReferenceField, Datagrid, FunctionField} from "react-admin";

export default function FeedbacksList(props) {
    return (
    <List title='Feedbacks' pagination={false} {...props}>
        <Datagrid>
            <TextField source="id" label="ID"/>
            <ReferenceField label="User" source="user_id" reference="USERS">
                <FunctionField label="Name" render={record => `${record.user_fname} ${record.user_lname}`} />
            </ReferenceField>
            <TextField source="feedback_msg" label="Message"/>
            <DateField source="feedback_date" label="Sent On" />
        </Datagrid>
    </List>
    );
};