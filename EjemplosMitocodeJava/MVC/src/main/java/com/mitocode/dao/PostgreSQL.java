package com.mitocode.dao;

public class PostgreSQL implements Conexion{

	@Override
	public void conectar() {
		System.out.println("Conexi�n a POSTGRESQL");
	}

}
