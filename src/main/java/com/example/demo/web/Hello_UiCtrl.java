package com.example.demo.web;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class Hello_UiCtrl {

	@RequestMapping("/")
	public String index() {
		return "index";
	}

}
