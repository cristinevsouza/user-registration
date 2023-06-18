import React, { useState } from 'react';
import './InputUserId.css';

function InputUserId({ handleShowForm }) {
  const [userId, setUserId] = useState('');

  const handleInputChange = (event) => {
    setUserId(event.target.value);
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    //api
    handleShowForm();
  };

  return (
    <div className='div-input-userId'>
      <h1>Search User by ID</h1>
      <form onSubmit={handleSubmit}>
        <label htmlFor="userId">User ID:</label>
        <input
          type="text"
          id="userId"
          value={userId}
          onChange={handleInputChange}
        />
        <button type="submit">Search</button>
      </form>
    </div>
  );
}

export default InputUserId;
