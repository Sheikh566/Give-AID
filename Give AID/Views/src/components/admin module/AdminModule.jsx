import React from "react";
import { Admin, Resource } from "react-admin";
import myDataProvider from "./myDataProvider";
import PersonOutlineIcon from '@mui/icons-material/PersonOutline';
import ManageAccountsOutlinedIcon from '@mui/icons-material/ManageAccountsOutlined';
import VolunteerActivismOutlinedIcon from '@mui/icons-material/VolunteerActivismOutlined';
import ReceiptLongOutlinedIcon from '@mui/icons-material/ReceiptLongOutlined';
import EventOutlinedIcon from '@mui/icons-material/EventOutlined';
import CollectionsOutlinedIcon from '@mui/icons-material/CollectionsOutlined';
import WorkOutlineOutlinedIcon from '@mui/icons-material/WorkOutlineOutlined';
import PeopleAltOutlinedIcon from '@mui/icons-material/PeopleAltOutlined';
import FeedbackOutlinedIcon from '@mui/icons-material/FeedbackOutlined';
import UserCreate from "./USER/UserCreate";
import UsersList from "./USER/UsersList";
import UserEdit from "./USER/UserEdit";
import AdminsList from "./ADMIN/AdminsList";
import AdminCreate from "./ADMIN/AdminCreate";
import AdminEdit from "./ADMIN/AdminEdit";
import CauseCreate from "./CAUSE/CauseCreate";
import CausesList from './CAUSE/CausesList';
import CauseEdit from './CAUSE/CauseEdit';
import DonationsList from "./DONATIONS/DonationsList";
import EventsList from "./EVENT/EventsList"
import EventCreate from "./EVENT/EventCreate"
import EventEdit from "./EVENT/EventEdit"
import JobsList from "./JOB/JobsList";
import JobCreate from "./JOB/JobCreate";
import JobEdit from "./JOB/JobEdit";
import PartnersList from "./PARTNER/PartnersList";
import PartnerEdit from "./PARTNER/PartnerEdit";
import PartnerCreate from "./PARTNER/PartnerCreate";
import FeedbacksList from "./FEEDBACK/FeedbacksList";



export default function AdminModule() {
  return (
    <>
      <Admin
        title="Give AID Admin Panel"
        dataProvider={myDataProvider}
      >
        <Resource name="users" list={UsersList} create={UserCreate} edit={UserEdit} icon={PersonOutlineIcon}/>
        <Resource name="admins" list={AdminsList} create={AdminCreate} edit={AdminEdit} icon={ManageAccountsOutlinedIcon}/>
        <Resource name="causes" list={CausesList} create={CauseCreate} edit={CauseEdit} icon={VolunteerActivismOutlinedIcon}/>
        <Resource name="donations" list={DonationsList} icon={ReceiptLongOutlinedIcon}/>
        <Resource name="events" list={EventsList} create={EventCreate} edit={EventEdit} icon={EventOutlinedIcon}/>
        <Resource name="gallery" icon={CollectionsOutlinedIcon}/>
        <Resource name="jobs" list={JobsList} create={JobCreate} edit={JobEdit} icon={WorkOutlineOutlinedIcon}/>
        <Resource name="partners" list={PartnersList} create={PartnerCreate} edit={PartnerEdit} icon={PeopleAltOutlinedIcon}/>
        <Resource name="feedbacks" list={FeedbacksList} icon={FeedbackOutlinedIcon}/>
      </Admin>
    </>
  );
}
