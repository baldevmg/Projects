package com.example.kafka.Kafkademo.Service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.kafka.core.KafkaTemplate;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;


@Service
public class Producer {

    @Autowired
    KafkaTemplate<String,String> kafkaTemplate;

    List<String> listOfMessages = new ArrayList<String>();

    public String sendMsgToTopic(String message){
        kafkaTemplate.send("SonataTopic",message);
        listOfMessages.add(message);
        return message;
    }

    public List<String> getAllMessages(){
        return listOfMessages;
    }
}
