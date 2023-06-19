import React, { useEffect, useState } from 'react';
import './UserList.css';

function UsersList({ handleSelectUser, handleGoBack }) {
  const [users, setUsers] = useState([]);

  const handleClick = (entry) => {
    const user = {
      id: entry.user.id,
      firstName: entry.user.firstName,
      lastName: entry.user.lastName,
      cpf: entry.user.cpf,
      dateOfBirth: entry.user.dateOfBirth,
      email: entry.user.email,
      phoneNumber: entry.user.phoneNumber,
      zipCode: entry.userAddress.zipCode,
      state: entry.userAddress.state,
      city: entry.userAddress.city,
      neighborhood: entry.userAddress.neighborhood,
      street: entry.userAddress.street,
      number: entry.userAddress.number,
      complement: entry.userAddress.complement,
      reference: entry.userAddress.reference
    };
   
    handleSelectUser(user);
  };
  
  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch('https://localhost:44396/api/registration/v1/GetAllRegistrations');
        if (response.ok) {
          const data = await response.json();
          setUsers(data);
        } else {
          throw new Error('Failed to fetch users list data');
        }
      } catch (error) {
        console.log(error);
      } 
    };

    fetchData();
  }, []);

  const handleMouseEnter = (e) => {
    e.target.style.cursor = 'pointer';
  };
  
  return (
    <div className="user-list">
      <h1>User List</h1>
      {(
        <>
          {users.map((entry, index) => (
            <div
              key={index}
              className="div-users"
              onClick={() => handleClick(entry)}
              onMouseEnter={handleMouseEnter}
            >
              <h3>{index + 1} - User Data:</h3>
              <p>Name: {entry.user.firstName} {entry.user.lastName}</p>
              <p>CPF: {entry.user.cpf}</p>
              <p>Date of Birth: {new Date(entry.user.dateOfBirth).toLocaleDateString()}</p>
              <p>Email: {entry.user.email}</p>
              <p>Phone Number: {entry.user.phoneNumber}</p>
              <p>ZIP Code: {entry.userAddress.zipCode}</p>
              <p>State: {entry.userAddress.state}</p>
              <p>City: {entry.userAddress.city}</p>
              <p>Neighborhood: {entry.userAddress.neighborhood}</p>
              <p>Street: {entry.userAddress.street}</p>
              <p>Number: {entry.userAddress.number}</p>
              <p>Complement: {entry.userAddress.complement}</p>
              <p>Reference: {entry.userAddress.reference}</p>
            </div>
          ))}
        </>
      )}
      <a href="#" onClick={handleGoBack}>Go Back</a>
    </div>
  );
}

export default UsersList;
