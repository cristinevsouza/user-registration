import React, { useState } from 'react';
import './Main.css';
import Form from './pages/Form';
import UsersList from './pages/UsersList';
import InputUserId from './pages/InputUserId';

function Main() {
  const [showForm, setShowForm] = useState(false);
  const [showUserList, setShowUserList] = useState(false);
  const [selectedUser, setSelectedUser] = useState(null);

  const handleSelectUser = (user) => {
    setSelectedUser(user);
    setShowForm(true);
  };

  const handleShowForm = () => {
    setShowForm(true);
    setShowUserList(false);
  };

  const handleGoBack = () => {
    setShowForm(false);
    setShowUserList(false);
  };

  const handleViewUser = () => {
    setShowForm(false);
    setShowUserList(false);
  };

  const handleShowUserList = () => {
    setShowUserList(true);
  };
  console.log(selectedUser)
  return (
    <main>
      {showForm ? (
        <Form 
        selectedUser={selectedUser}
        handleGoBack={handleGoBack} />
      ) : showUserList ? (
        <UsersList 
          handleSelectUser={handleSelectUser}
          handleGoBack={handleGoBack}
        />
      ) : (
        <>
          <div className='buttons-main'>
            <button onClick={handleShowForm}>
              New User
            </button>
            <button onClick={handleShowUserList}>
              List All
            </button>
          </div>
          <div>
            <InputUserId handleSelectUser={handleSelectUser} />
          </div>
        </>     
      )}
    </main>
  );
}

export default Main;