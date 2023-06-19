import React, { useState } from 'react';
import './InputUserId.css';

function InputUserId({ handleSelectUser }) {
  const [userId, setUserId] = useState('');
  const [userData, setUserData] = useState({});

  const handleInputChange = (event) => {
    setUserId(event.target.value);
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    
    let urlApi= 'https://localhost:44396/api/registration/v1/GetRegistrationByUserId/?userId=';

    fetch(urlApi + userId)
      .then(response => response.json())
      .then(data => {

        setUserData(data);

        const userData = {
          id: data.user.id,
          firstName: data.user.firstName,
          lastName: data.user.lastName,
          cpf: data.user.cpf,
          dateOfBirth: data.user.dateOfBirth,
          email: data.user.email,
          phoneNumber: data.user.phoneNumber,
          zipCode: data.userAddress.zipCode,
          state: data.userAddress.state,
          city: data.userAddress.city,
          neighborhood: data.userAddress.neighborhood,
          street: data.userAddress.street,
          number: data.userAddress.number,
          complement: data.userAddress.complement,
          reference: data.userAddress.reference
        };
  
        handleSelectUser(userData);
      })
      .catch(error => {
        console.log(error);
      });     
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
