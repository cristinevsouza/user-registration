import React, { useState } from 'react';
import './Main.css';
import Form from './pages/Form';
import UsersList from './pages/UsersList';
import ViewUser from './pages/ViewUser';
import InputUserId from './pages/InputUserId';

function Main() {
  const [showForm, setShowForm] = useState(false);
  const [viewUser, setViewUser] = useState(false);
  const [showUserList, setShowUserList] = useState(false);

  const handleShowForm = () => {
    setShowForm(true);
    setViewUser(false);
    setShowUserList(false);
  };

  const handleGoBack = () => {
    setShowForm(false);
    setViewUser(false);
    setShowUserList(false);
  };

  const handleViewUser = () => {
    setShowForm(false);
    setViewUser(true);
    setShowUserList(false);
  };

  const handleShowUserList = () => {
    setShowUserList(true);
    setShowForm(false);
    setViewUser(false);
  };

  return (
    <main>
      {showForm ? (
        <Form handleGoBack={handleGoBack} handleViewUser={handleViewUser} />
      ) : viewUser ? (
        <ViewUser handleGoBack={handleGoBack} />
      ) : showUserList ? (
        <UsersList 
        handleButtonClick={handleShowForm} 
        handleViewUser={handleViewUser} 
        handleGoBack={handleGoBack}
        handleShowForm={handleShowForm}/>
      ) : (
        <>
          <div className='buttons-main'>
            <button onClick={handleShowForm}>
              New user
            </button>
            <button onClick={handleShowUserList} handleShowForm={handleShowForm}>
              List All Users
            </button>
          </div>
          <div>
            <InputUserId handleShowForm={handleShowForm} />
          </div>
        </>     
      )}
    </main>
  );
}

export default Main;
