import React, { useState, useEffect } from 'react';

function UserEditor({ userId }) {
  const [user, setUser] = useState({});

  useEffect(() => {
    if (userId) {
      fetch(`/api/users/${userId}`)
        .then(res => res.json())
        .then(data => setUser(data));
    }
  }, [userId]);

  function handleSubmit(e) {
    e.preventDefault();
    fetch(`/api/users/${userId || 'createuser'}`, {
      method: userId ? 'PUT' : 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(user)
    });
  }

  function handleChange(e) {
    setUser({ ...user, [e.target.name]: e.target.value });
  }

  return (
    <form onSubmit={handleSubmit}>
      <input name="name" value={user.name} onChange={handleChange} />
      <input name="login" value={user.login} onChange={handleChange} />
      <button type="submit">Save</button>
    </form>
  );
}

export default UserEditor;