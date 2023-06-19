import React, { useState, useEffect } from 'react';
import './Form.css';
import InputField from '../InputField';

function RegistrationForm({ handleGoBack, selectedUser }) {
  const [formData, setFormData] = useState({
    id: 0,
    firstName: '',
    lastName: '',
    cpf: '',
    dateOfBirth: '',
    email: '',
    phoneNumber: '',
    zipCode: '',
    state: '',
    city: '',
    neighborhood: '',
    street: '',
    number: '',
    complement: '',
    reference: ''
  });
  const [submitted, setSubmitted] = useState(false);

  useEffect(() => {
    if (selectedUser) {
      setFormData(selectedUser);
    }
  }, [selectedUser]);

  const handleChange = (e) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    try {
      const requestBody = {
        userDto: {
          id: formData.id,
          cpf: formData.cpf,
          firstName: formData.firstName,
          lastName: formData.lastName,
          dateOfBirth: formData.dateOfBirth,
          email: formData.email,
          phoneNumber: formData.phoneNumber
        },
        userAddressDto: {
          zipCode: formData.zipCode,
          state: formData.state,
          city: formData.city,
          neighborhood: formData.neighborhood,
          street: formData.street,
          number: formData.number,
          complement: formData.complement,
          reference: formData.reference
        }
      };

      let requestedMethod = 'POST';
      let urlSufix = 'AddUserRegistration';
      let urlApi = 'https://localhost:44396/api/registration/v1/';

      if (formData.id > 0) {
        console.log(formData.id);
        requestedMethod = 'PUT';
        urlSufix = 'UpdateUserRegistration';
      }

      const response = await fetch(urlApi + urlSufix, {
        method: requestedMethod,
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(requestBody)
      });

      if (response.ok) {
        setSubmitted(true);
      } else {
        console.error('Erro ao enviar os dados do formulário');
      }
    } catch (error) {
      console.error('Erro ao enviar os dados do formulário:', error);
    }
  };

  const formatDate = (date) => {
    if (!date) return '';

    const formattedDate = new Date(date).toISOString().split('T')[0];
    return formattedDate;
  };

  return (
    <div className="div-form">
      {!submitted ? (
        <div className="container">
          <form className="registration-form" onSubmit={handleSubmit}>
            <div className="form-row">
              <InputField
                label="First name:"
                id="first-name"
                name="firstName"
                value={formData.firstName}
                onChange={handleChange}
              />
              <InputField
                label="Last name:"
                id="last-name"
                name="lastName"
                value={formData.lastName}
                onChange={handleChange}
              />
              <InputField
                label="CPF:"
                id="cpf"
                name="cpf"
                value={formData.cpf}
                onChange={handleChange}
              />
              <InputField
                label="Date of Birth:"
                id="birth-date"
                name="dateOfBirth"
                type="date"
                value={formatDate(formData.dateOfBirth)}
                onChange={handleChange}
              />
              <InputField
                label="PhoneNumber:"
                id="phoneNumber"
                name="phoneNumber"
                value={formData.phoneNumber}
                onChange={handleChange}
              />
              <InputField
                label="Email:"
                id="email"
                name="email"
                value={formData.email}
                onChange={handleChange}
              />
              <InputField
                label="Zip Code:"
                id="zip-code"
                name="zipCode"
                value={formData.zipCode}
                onChange={handleChange}
              />
              <InputField
                label="State:"
                id="state"
                name="state"
                value={formData.state}
                onChange={handleChange}
              />
              <InputField
                label="City:"
                id="city"
                name="city"
                value={formData.city}
                onChange={handleChange}
              />
              <InputField
                label="Neighborhood:"
                id="neighborhood"
                name="neighborhood"
                value={formData.neighborhood}
                onChange={handleChange}
              />
              <InputField
                label="Street:"
                id="street"
                name="street"
                value={formData.street}
                onChange={handleChange}
              />
              <InputField
                label="Number:"
                id="number"
                name="number"
                value={formData.number}
                onChange={handleChange}
              />
              <InputField
                label="Complement:"
                id="complement"
                name="complement"
                value={formData.complement}
                onChange={handleChange}
              />
              <InputField
                label="Reference:"
                id="reference"
                name="reference"
                value={formData.reference}
                onChange={handleChange}
              />
            </div>
            <div className="div-button">
              <button type="submit">Send</button>
            </div>
          </form>
        </div>
      ) : (
        <div className="success-message">
          <h2>Success!</h2>
          <p>Dados:</p>
          <p>Nome: {formData.firstName} {formData.lastName}</p>
          <p>CPF: {formData.cpf}</p>
          <p>Data de Nascimento: {formData.dateOfBirth}</p>
          <p>Email: {formData.email}</p>
          <p>Número de telefone: {formData.phoneNumber}</p>
          <p>CEP: {formData.zipCode}</p>
          <p>Estado: {formData.state}</p>
          <p>Cidade: {formData.city}</p>
          <p>Bairro: {formData.neighborhood}</p>
          <p>Rua: {formData.street}</p>
          <p>Número: {formData.number}</p>
          <p>Complemento: {formData.complement}</p>
          <p>Referência: {formData.reference}</p>
        </div>
      )}
      <a href="#" onClick={handleGoBack}>Go Back</a>
    </div>
  );
}

export default RegistrationForm;
