import React from 'react';

const InputField = ({ label, id, type, name, value, onChange }) => {
  return (
    <div>
      <label htmlFor={id}>{label}</label>
      <input type={type} id={id} name={name} value={value} onChange={onChange} />
    </div>
  );
};

export default InputField;
