import React from 'react';

const InputField = ({ label, id, name, value, onChange }) => {
  return (
    <div>
      <label htmlFor={id}>{label}</label>
      <input type="text" id={id} name={name} value={value} onChange={onChange} />
    </div>
  );
};

export default InputField;
