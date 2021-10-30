package com.mitocode.strategy;

public class AntivirusSimple extends AnalisisSimple{

	@Override
	void iniciar() {
		System.out.println("Antivirus Simple - An�lisis simple iniciado");
	}

	@Override
	void saltarZip() {
		try {			
			System.out.println("Analizando...");
			Thread.sleep(2500);				
			System.out.println("No se pudo analizar archivos con extensi�n '.zip'");
		} catch (InterruptedException e) {
			e.printStackTrace();
		}				
	}

	@Override
	void detener() {
		System.out.println("Antivirus Simple - An�lisis simple finalizado");		
	}

}
