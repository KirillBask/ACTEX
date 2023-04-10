import React, { useState } from "react";
import axios from "axios";
import { BASE_URL } from "./config";

function User(props) {
  const [editing, setEditing] = useState(false);
  const [user, setUser] = useState(props.user);

  function handleEdit() {
    setEditing(true);
  }

  function handleDelete() {
    axios
      .delete(`${BASE_URL}/Users/DeleteUser/${user.id}`)
      .then(() => props.onDelete(user.id))
      .catch((error) => console.log(error));
  }

  function handleSave(updatedUser) {
    axios
      .put(`${BASE_URL}/Users/UpdateUser/${user.id}`, updatedUser)
      .then(() => {
        setUser(updatedUser);
        setEditing(false);
      })
      .catch((error) => console.log(error));
  }

  if (editing) {
    return <UserEdit user={user} onSave={handleSave} />;
  }

  return (
    <tr>
      <td>{user.id}</td>
      <td>{user.login}</td>
      <td>{user.password}</td>
      <td>{user.name}</td>
      <td>{user.typeId}</td>
      <td>{user.lastVisitDate}</td>
      <td>
        <button onClick={handleEdit}>Edit</button>
        <button onClick={handleDelete}>Delete</button>
      </td>
    </tr>
  );
}

function UserEdit(props) {
  const [user, setUser] = useState(props.user);

  function handleChange(e) {
    setUser({ ...user, [e.target.name]: e.target.value });
  }

  function handleSubmit(e) {
    e.preventDefault();
    props.onSave(user);
  }

  return (
    <form onSubmit={handleSubmit}>
      <label>
        Id:
        <input name="id" value={user.id} onChange={handleChange} disabled />
      </label>
      <br />
      <label>
        Login:
        <input name="login" value={user.login} onChange={handleChange} />
      </label>
      <br />
      <label>
        Password:
        <input name="password" value={user.password} onChange={handleChange} />
      </label>
      <br />
      <label>
        Name:
        <input name="name" value={user.name} onChange={handleChange} />
      </label>
      <br />
      <label>
        TypeId:
        <input name="typeId" value={user.typeId} onChange={handleChange} />
      </label>
      <br />
      <label>
        Last Visit Date:
        <input
          type="date"
          name="lastVisitDate"
          value={user.lastVisitDate}
          onChange={handleChange}
        />
      </label>
      <br />
      <button type="submit">Save</button>
    </form>
  );
}

export default User;
