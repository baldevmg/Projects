package com.sonata.controller;

import com.sonata.service.LlamaAiService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
@CrossOrigin(value = "http://localhost:3000/")
public class APIController {

        @Autowired
        private LlamaAiService aiService;
        @GetMapping("/api/ai/generate")
        public String generation(@RequestParam(value = "promptMessage") String promptMessage) {
             return aiService.generateResult(promptMessage);
        }
    }