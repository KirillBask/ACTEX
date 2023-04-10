import React, { useState } from "react";
import axios from "axios";
import { BASE_URL } from "./config";
import "./App";
import UsersList from "./UsersList";

function UserCreate() {
  const [id, setId] = useState();
  const [login, setLogin] = useState();
  const [password, setPassword] = useState();
  const [name, setName] = useState();
  const [typeId, setTypeId] = useState();
  const [lastVisitDate, setLastVisitDate] = useState(new Date().toISOString());

  function handleSubmit() {
    axios
      .post(`${BASE_URL}/Users/CreateUser`, {
        id,
        login,
        password,
        name,
        typeId,
        lastVisitDate,
      })
      .then(() => {
        setId(null);
        setLogin(null);
        setPassword(null);
        setName(null);
        setTypeId(null);
        setLastVisitDate(null);
      })
      .then(() => UsersList());
  }

  return (
    <div>
      <h1>Добавить пользователя</h1>
      <form onSubmit={handleSubmit}>
        <input
          name="id"
          placeholder="id"
          value={id}
          onChange={(e) => setId(e.target.value)}
        />{" "}
        <input
          name="login"
          placeholder="login"
          value={login}
          onChange={(e) => setLogin(e.target.value)}
        />{" "}
        <input
          name="password"
          placeholder="password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
        />{" "}
        <input
          name="name"
          placeholder="name"
          value={name}
          onChange={(e) => setName(e.target.value)}
        />{" "}
        <input
          name="typeId"
          placeholder="typeId"
          value={typeId}
          onChange={(e) => setTypeId(e.target.value)}
        />{" "}
        <button type="submit" className="filter-button">
          Save
        </button>
        <button
          type="submit"
          onClick={() => {
            UsersList();
          }}
          className="filter-button"
        >
          Back
        </button>
      </form>
    </div>
  );
}

export default UserCreate;
