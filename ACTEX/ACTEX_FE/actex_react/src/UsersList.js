import React, { useState, useEffect } from "react";
import axios from "axios";
import { BASE_URL } from "./config";

function UsersList() {
  const [users, setUsers] = useState([]);
  const [filter, setFilter] = useState({
    id: "",
    login: "",
    password: "",
    name: "",
    typeId: "",
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

  return (
    <div>
      <h1>Пользователи</h1>
      <form onSubmit={handleSubmit}>
        <input name="id" value={filter.id} onChange={handleChange} />
        <input name="login" value={filter.login} onChange={handleChange} />
        <input
          name="password"
          value={filter.password}
          onChange={handleChange}
        />
        <input name="name" value={filter.name} onChange={handleChange} />
        <input name="typeId" value={filter.typeId} onChange={handleChange} />
        <input
          type="date"
          name="lastVisitDate"
          value={filter.lastVisitDate}
          onChange={handleChange}
        />
        <button type="submit">Фильтр</button>
      </form>
      <table>
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
            <td>{user.type_id}</td>
            <td>{user.last_visit_date}</td>
          </tr>
        ))}
      </table>
    </div>
  );
}

export default UsersList;
