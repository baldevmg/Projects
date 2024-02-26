package com.sonata.model

import org.springframework.beans.factory.annotation.Value
import org.springframework.boot.context.properties.ConfigurationProperties
import org.springframework.stereotype.Component


@Component
@ConfigurationProperties(prefix = "udas")
class YamlModel {
    @Value("#{\${udas}}")
    val key: Map<String, String>? = null
    var newline = System.lineSeparator()

    fun getValue():String {
            println("YamlModel{" +
                    "udas: Key 1 : " + key!!["Key 1"] +
                         " Key 2 : " + key!!["Key 2"] +
                         " Key 3 : " + key!!["Key 3"] +
                    '}' + newline + key)
            return "YamlModel{" +
                    "udas: Key 1 : " + key!!["Key 1"] + " Key 2 : " + key!!["Key 2"] + " Key 3 : " + key!!["Key 3"] +
                    '}' + newline + key
        }
}
