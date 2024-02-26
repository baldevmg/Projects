package com.example.kafka.Kafkademo.Service;

import org.springframework.kafka.annotation.KafkaListener;
import org.springframework.stereotype.Service;


@Service
public class Consumer {
    @KafkaListener(topics="SonataTopic",groupId = "group_id")
    public void consume(String message)
    {
        System.out.println("Message from Producer = " + message);
    }

}
