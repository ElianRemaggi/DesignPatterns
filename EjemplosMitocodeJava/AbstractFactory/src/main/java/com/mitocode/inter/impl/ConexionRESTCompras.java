package com.mitocode.inter.impl;

import com.mitocode.inter.IConexionREST;

public class ConexionRESTCompras implements IConexionREST{

	@Override
	public void leerURL(String url) {		
		System.out.println("Conect�ndose a " + url);
	}

}
