package com.sonata.controller

import com.sonata.model.YamlModel
import org.springframework.beans.factory.annotation.Autowired
import org.springframework.context.annotation.Bean
import org.springframework.context.annotation.ComponentScan
import org.springframework.web.bind.annotation.GetMapping
import org.springframework.web.bind.annotation.RequestMapping
import org.springframework.web.bind.annotation.RestController

@RestController
@ComponentScan("com.sonata.yamlModel")
class YamlController {
    @Autowired
    var yamlModel: YamlModel? = null
    @RequestMapping("/path")
    fun yamlRead(): String {
        return yamlModel?.getValue() ?: "Default"
    }
}
