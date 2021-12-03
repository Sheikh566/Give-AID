import React from "react";
import { Admin, Resource } from "react-admin";
import simpleRestProvider from "ra-data-simple-rest";
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
import FeedbacksShow from "./FEEDBACK/FeedbacksShow";


export default function AdminModule() {
  return (
    <>
      <Admin
        title="Give AID Admin Panel"
        dataProvider={simpleRestProvider("https://localhost:44385/api")}
      >
        <Resource
          name="USERS"
          list={UsersList}
          create={UserCreate}
          edit={UserEdit}
        />
        <Resource name="ADMINS" list={AdminsList} create={AdminCreate} edit={AdminEdit} />
        <Resource name="CAUSES" list={CausesList} create={CauseCreate} edit={CauseEdit} />
        <Resource name="DONATIONS" list={DonationsList} />
        <Resource name="EVENTS" list={EventsList} create={EventCreate} edit={EventEdit}/>
        <Resource name="GALLERY"/>
        <Resource name="JOBS" list={JobsList} create={JobCreate} edit={JobEdit}/>
        <Resource name="PARTNERS" list={PartnersList} create={PartnerCreate} edit={PartnerEdit}/>
        <Resource name="FEEDBACKS" list={FeedbacksShow} />
      </Admin>
    </>
  );
}
