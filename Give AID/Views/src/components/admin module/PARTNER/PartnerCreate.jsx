import { Create, SimpleForm, TextInput, ImageInput} from 'react-admin'

export default function PartnerCreate(props) {
    return (
        <Create title="Add a partner" {...props}>
            <SimpleForm>
                <TextInput source='partner_name' label='Partner Name'/>
                <ImageInput source='partner_logo' label='Partner Logo'/>
            </SimpleForm>
        </Create>
    );
}