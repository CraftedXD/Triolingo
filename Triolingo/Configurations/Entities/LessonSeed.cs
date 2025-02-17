﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Triolingo.Domain;

namespace Triolingo.Configurations.Entities
{
    public class LessonSeed : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasData(
                new Lesson
                {
                    LessonId = 1,
                    LessonName = "Japanese Lesson 1",
                    LessonContent = "あ is pronounced like 'ah!' like when you come to a realization. It also sounds like the 'a' in 'car'.\n" +
                "い is pronounced like the 'ee' in 'eel'.\n" +
                "う is pronounced like theu in 'UNO' the card game, or the number one in Spanish.\n" +
                "え is pronounced like the e in 'egg'\n" +
                "お is pronounced like you're saying 'oh.' It also sounds like the o in 'origami'.",
                    LessonOrder = 1,
                    LanguageId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    LessonId = 2,
                    LessonName = "Japanese Lesson 2",
                    LessonContent = "か is just the K sound plus あ, making a ka sound. It's pronounced like ka in 'karma.'\n" +
                    "き is just the K sound plus い, making a ki sound. It sounds ike the word 'key'\n" +
                    "く is just the K sound plus う, making a ku sound. It's pronounced 'coo' like both syllables of the word 'cuckoo'.\n" +
                    "け is just the K sound plus え, making a ke sound. It's pronounced like ke in 'kelp.'\n" +
                    "こ is just the K sound plus お, making a ko sound. It's pronounced like co in 'coin'.",
                    LessonOrder = 2,
                    LanguageId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    LessonId = 3,
                    LessonName = "Chinese Lesson 1",
                    LessonContent = "一 is the number 1 in chinese and it's pronouced 'yī'\n" +
                    "二 is the number 2 in chinese and it's pronouced 'èr'\n" +
                    "三 in the number 3 in chinese it's pronouced 'sān'\n" +
                    "四 in the number 4 in chinese it's pronouced 'sì'\n" +
                    "五 in the number 4 in chinese it's pronouced 'wǔ'\n",
                    LessonOrder = 1,
                    LanguageId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    LessonId = 4,
                    LessonName = "Chinese Lesson 2",
                    LessonContent = "六 is the number 6 in chinese and it's pronouced 'liù'\n" +
                    "七 is the number 7 in chinese and it's pronouced 'qī'\n" +
                    "八 in the number 8 in chinese it's pronouced 'bā'\n" +
                    "九 in the number 9 in chinese it's pronouced 'jiǔ'\n" +
                    "十 in the number 10 in chinese it's pronouced 'shí'\n",
                    LessonOrder = 2,
                    LanguageId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                });
        }
    }
}
