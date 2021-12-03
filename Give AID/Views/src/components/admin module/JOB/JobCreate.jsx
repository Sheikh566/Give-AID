import { Create, SimpleForm, TextInput} from 'react-admin'

export default function JobCreate(props) {
    return (
        <Create title="Post a job" {...props}>
            <SimpleForm>
                <TextInput source='job_title' label='Job Title'/>
                <TextInput source='job_description' label='Job Description'/>
            </SimpleForm>
        </Create>
    );
}