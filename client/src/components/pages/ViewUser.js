import React, { useEffect, useState } from 'react';
import './ViewUser.css';

function ViewUser({ userId, handleGoBack }) {
  const [userData, setUserData] = useState({});
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    // api
    fetch(`sua-url-da-api/${userId}`)
      .then(response => response.json())
      .then(data => {
        setUserData(data);
        setIsLoading(false);
      })
      .catch(error => {
        console.log(error);
        setIsLoading(false);
      });
  }, [userId]);

  return (
    <div className="user">
      {isLoading ? (
        <p>Loading...</p>
      ) : (
        <>
          <h3>User Data:</h3>
          <p>Name: {userData.firstName} {userData.lastName}</p>
          <p>CPF: {userData.cpf}</p>
          <p>Date of Birth: {userData.dateOfBirth}</p>
          <p>Email: {userData.email}</p>
          <p>Phone Number: {userData.phoneNumber}</p>
          <p>ZIP Code: {userData.zipCode}</p>
          <p>State: {userData.state}</p>
          <p>City: {userData.city}</p>
          <p>Neighborhood: {userData.neighborhood}</p>
          <p>Street: {userData.street}</p>
          <p>Number: {userData.number}</p>
          <p>Complement: {userData.complement}</p>
          <p>Reference: {userData.reference}</p>
        </>
      )}
      <a href="#" onClick={handleGoBack}>Go Back</a>
    </div>
  );
}

export default ViewUser;
