package com.example.kafka.Kafkademo.Controller;

import com.example.kafka.Kafkademo.Service.Producer;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController

public class KafkaController {

    @Autowired
    Producer producer;

    @PostMapping("/sendMessage")
    public String sendMsg(@RequestParam("Msg") String message){
        return producer.sendMsgToTopic(message);
    }
    @GetMapping("/getMessage")
    public List<String> getMessages(){
        return producer.getAllMessages();
    }
}
