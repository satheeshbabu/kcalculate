package com.example.dietapp

import android.app.Application
import com.example.dietapp.di.component.AppComponent
import com.example.dietapp.di.component.DaggerAppComponent
import com.example.dietapp.models.dto.MealDTO
import com.example.dietapp.models.dto.MealEntryDTO
import com.example.dietapp.models.entity.Friend
import com.example.dietapp.models.dto.UserDTO

class DietApp : Application() {
    lateinit var appComponent: AppComponent

    //TODO: If possible, move state to Room, replace fields with observables, DO NOT leave as it is
    companion object {

        var mealEntries: List<MealEntryDTO>? = null
        var meals: MutableList<MealDTO> = mutableListOf()
        var filteredMeals: MutableList<MealDTO> = mutableListOf()
        var user: UserDTO? = null
        var friends: MutableList<Friend> = mutableListOf()
        var filteredFriends: MutableList<Friend> = mutableListOf()

    }

    init {
        filteredMeals.addAll(meals)
        filteredFriends.addAll(friends)
    }

    override fun onCreate() {
        super.onCreate()
        appComponent = DaggerAppComponent.factory().create(this)
    }
}