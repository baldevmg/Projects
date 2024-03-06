package com.sonata.nerapplication;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;

@ComponentScan("NERController")
@SpringBootApplication
public class NerApplication {

	public static void main(String[] args) {
		SpringApplication.run(NerApplication.class, args);
	}

}
