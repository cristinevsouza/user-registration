import React, { useEffect, useState } from 'react';
import './UserList.css';

function UsersList({ handleGoBack, handleShowForm }) {
  const [users, setUsers] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    // api
    fetch('your-api-url')
      .then(response => response.json())
      .then(data => {
        setUsers(data);
        setIsLoading(false);
      })
      .catch(error => {
        console.log(error);
        setIsLoading(false);
      });
  }, []);

  const handleMouseEnter = (e) => {
    e.target.style.cursor = 'pointer';
  };

  const handleClick = () => {
    handleShowForm();
  };

  return (
    <div className="user-list">
      <h1>User List</h1>
      <div className="user" onClick={handleClick} onMouseEnter={handleMouseEnter}>
        <h3>User Data:</h3>
        <p>Name: Cristine Vieira</p>
        <p>CPF: 000.000.000.00</p>
        <p>Date of Birth: 12/07/1990</p>
        <p>Email: teste@teste.com</p>
        <p>Phone Number: 489999999999</p>
        <p>ZIP Code: 88888888</p>
        <p>State: AM</p>
        <p>City: Manaus</p>
        <p>Neighborhood: Centro</p>
        <p>Street: Rua Salvador França</p>
        <p>Number: 800</p>
        <p>Complement: 6b</p>
        <p>Reference: Em frente a praça.</p>
      </div>
      <div className="user" onClick={handleClick} onMouseEnter={handleMouseEnter}>
        <h3>User Data:</h3>
        <p>Name: Cristine Vieira</p>
        <p>CPF: 000.000.000.00</p>
        <p>Date of Birth: 12/07/1990</p>
        <p>Email: teste@teste.com</p>
        <p>Phone Number: 489999999999</p>
        <p>ZIP Code: 88888888</p>
        <p>State: AM</p>
        <p>City: Manaus</p>
        <p>Neighborhood: Centro</p>
        <p>Street: Rua Salvador França</p>
        <p>Number: 800</p>
        <p>Complement: 6b</p>
        <p>Reference: Em frente a praça.</p>
      </div>
      {users.map((user, index) => (
        <div
          key={index}
          className="user"
          onClick={handleClick}
          onMouseEnter={handleMouseEnter}
        >
          <h3>User Data:</h3>
          <p>Name: {user.firstName} {user.lastName}</p>
          <p>CPF: {user.cpf}</p>
          <p>Date of Birth: {user.dateOfBirth}</p>
          <p>Email: {user.email}</p>
          <p>Phone Number: {user.phoneNumber}</p>
          <p>ZIP Code: {user.zipCode}</p>
          <p>State: {user.state}</p>
          <p>City: {user.city}</p>
          <p>Neighborhood: {user.neighborhood}</p>
          <p>Street: {user.street}</p>
          <p>Number: {user.number}</p>
          <p>Complement: {user.complement}</p>
          <p>Reference: {user.reference}</p>
        </div>
      ))}
      <a href="#" onClick={handleGoBack}>
        Go Back
      </a>
    </div>
  );
}

export default UsersList;
