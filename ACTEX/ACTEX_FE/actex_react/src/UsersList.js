import React, { useState, useEffect } from "react";
import axios from "axios";
import { BASE_URL } from "./config";
import "./App";
import UserCreate from "./UserCreate";
import User from "./User";

function UsersList() {
  
  const [addingUser, setAddingUser] = useState(false);
  const [users, setUsers] = useState([]);
  const [selectedUser, setSelectedUser] = useState(null);
  const [filter, setFilter] = useState({
    id: null,
    login: null,
    password: null,
    name: null,
    typeId: null,
    lastVisitDate: null,
  });
  
  useEffect(() => {
    axios
    .post(`${BASE_URL}/Users/GetUsers`, { filter })
      .then((res) => setUsers(res.data));
    }, [filter]);

    function handleChange(e) {
    setFilter({ ...filter, [e.target.name]: e.target.value });
  }

  function handleSubmit(e) {
    e.preventDefault();
    axios
    .post(`${BASE_URL}/Users/GetUsers`, filter)
    .then((res) => setUsers(res.data));
  }
  
  function handleAdd() {
    setAddingUser(true);
  }
  
  if (addingUser) {
    return <UserCreate />;
  }
  return (
    <div>
      <h1>Пользователи</h1>
      <form onSubmit={handleSubmit} className="filter-form">
        {" "}
        <input
          name="id"
          placeholder="id"
          value={filter.id || ""}
          onChange={handleChange}
          className="filter-input"
        />{" "}
        <input
          name="login"
          placeholder="login"
          value={filter.login || ""}
          onChange={handleChange}
          className="filter-input"
        />{" "}
        <input
          name="password"
          placeholder="password"
          value={filter.password || ""}
          onChange={handleChange}
          className="filter-input"
        />{" "}
        <input
          name="name"
          placeholder="name"
          value={filter.name || ""}
          onChange={handleChange}
          className="filter-input"
        />{" "}
        <input
          name="typeId"
          placeholder="typeId"
          value={filter.typeId || ""}
          onChange={handleChange}
          className="filter-input"
        />{" "}
        <input
          type="date"
          placeholder="date"
          name="lastVisitDate"
          value={filter.lastVisitDate || undefined}
          onChange={handleChange}
          className="filter-input"
        />{" "}
        <button type="submit" className="filter-button">
          Фильтр
        </button>{" "}
        <button type="button" onClick={handleAdd} className="filter-button">
          Add
        </button>{" "}
      </form>
      {selectedUser ? (
        <User user={selectedUser} />
      ) : (
        <table border="1" className="user-table">
          <tbody>
            <tr>
              <th>Id</th>
              <th>Логин</th>
              <th>Пароль</th>
              <th>Имя</th>
              <th>TypeId</th>
              <th>Дата последнего посещения</th>
            </tr>
            {users.map((user) => (
              <tr key={user.id}>
                <td>{user.id}</td>
                <td>{user.login}</td>
                <td>{user.password}</td>
                <td>{user.name}</td>
                <td>{user.typeId}</td>
                <td>{user.lastVisitDate}</td>
                <tr>
                  <button type="button" key={user.id} onClick={() => setSelectedUser(user)}>Edit</button>
                </tr>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
}

export default UsersList;
