import React from "react";
import { Admin, Resource } from "react-admin";
import simpleRestProvider from "ra-data-simple-rest";
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
        dataProvider={simpleRestProvider("https://localhost:44385/api")}
      >
        <Resource name="USERS" list={UsersList} create={UserCreate} edit={UserEdit} icon={PersonOutlineIcon}/>
        <Resource name="ADMINS" list={AdminsList} create={AdminCreate} edit={AdminEdit} icon={ManageAccountsOutlinedIcon}/>
        <Resource name="CAUSES" list={CausesList} create={CauseCreate} edit={CauseEdit} icon={VolunteerActivismOutlinedIcon}/>
        <Resource name="DONATIONS" list={DonationsList} icon={ReceiptLongOutlinedIcon}/>
        <Resource name="EVENTS" list={EventsList} create={EventCreate} edit={EventEdit} icon={EventOutlinedIcon}/>
        <Resource name="GALLERY" icon={CollectionsOutlinedIcon}/>
        <Resource name="JOBS" list={JobsList} create={JobCreate} edit={JobEdit} icon={WorkOutlineOutlinedIcon}/>
        <Resource name="PARTNERS" list={PartnersList} create={PartnerCreate} edit={PartnerEdit} icon={PeopleAltOutlinedIcon}/>
        <Resource name="FEEDBACKS" list={FeedbacksList} icon={FeedbackOutlinedIcon}/>
      </Admin>
    </>
  );
}
