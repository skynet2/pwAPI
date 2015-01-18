using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JQEditor;
using pwAPI;

namespace JQEditor.Classes
{
    public class CONVERSATION
    {
        public int crypt_key; // айди квеста

        public int prompt_character_count; // m_ulDescript
        public byte[] prompt_text; // m_pwstrDescript

        public int m_ulOkText; // m_ulOkText
        public byte[] m_pwstrOkText; // m_pwstrOkText

        public int m_ulNoText; // m_ulNoText
        public byte[] m_pwstrNoText; // m_pwstrNoText

        public int general_character_count; // m_ulTribute
        public byte[] general_text; // m_pwstrTribute

        public DIALOG[] dialogs; // масив диалогов(размер 5)m_DelvTaskTalk,m_UnqualifiedTalk,m_DelvItemTalk,m_ExeTalk,m_AwardTalk

        public string GeneralText
        {
            get { return TasksExtensions.Decrypt(crypt_key, general_text); }
			set { general_text = TasksExtensions.Encrypt(crypt_key, value.TrimEnd(new char[1] { char.MinValue }), value.TrimEnd(new char[1] { char.MinValue }).Length * 2 + 2, 1 != 0); general_character_count = general_text.Length / 2; }
        }

        public string OkText
        {
			get { return TasksExtensions.Decrypt(crypt_key, m_pwstrOkText); }
			set { general_text = TasksExtensions.Encrypt(crypt_key, value.TrimEnd(new char[1] { char.MinValue }), value.TrimEnd(new char[1] { char.MinValue }).Length * 2 + 2, 1 != 0); m_ulOkText = OkText.Length / 2; }
        }

        public string NoText
        {
			get { return TasksExtensions.Decrypt(crypt_key, m_pwstrNoText); }
			set { general_text = TasksExtensions.Encrypt(crypt_key, value.TrimEnd(new char[1] { char.MinValue }), value.TrimEnd(new char[1] { char.MinValue }).Length * 2 + 2, 1 != 0); m_ulNoText = m_pwstrNoText.Length / 2; }
        }

        public string PromptText
        {
			get { return TasksExtensions.Decrypt(crypt_key, prompt_text); }
			set { prompt_text = TasksExtensions.Encrypt(crypt_key, value.TrimEnd(new char[1] { char.MinValue }), value.TrimEnd(new char[1] { char.MinValue }).Length * 2 + 2, 1 != 0); prompt_character_count = prompt_text.Length / 2; }
        }
    }
    public class DIALOG
    {
        public int crypt_key;
        public int unknown;
        public byte[] dialog_text;
        public int question_count;
        public QUESTION[] questions;

        public string DialogText
        {
			get { return TasksExtensions.Decrypt(crypt_key, dialog_text); }
			set { dialog_text = TasksExtensions.Encrypt(crypt_key, value, 128, false); }
        }
    }
    public class QUESTION
    {
        public int crypt_key;
        public int question_id;
        public int previous_question;
        public int question_character_count;
        public byte[] question_text;
        public int answer_count;
        public ANSWER[] answers;

        public string QuestionText
        {
			get { return TasksExtensions.Decrypt(crypt_key, question_text); }
			set { question_text = TasksExtensions.Encrypt(crypt_key, value.TrimEnd(new char[1] { char.MinValue }), value.TrimEnd(new char[1] { char.MinValue }).Length * 2 + 2, 1 != 0); question_character_count = question_text.Length / 2; }
        }
    }
    public class ANSWER
    {
        public int crypt_key;
        public int question_link;
        public byte[] answer_text;
        public int task_link;

        public string AnswerText
        {
			get { return TasksExtensions.Decrypt(crypt_key, answer_text); }
			set { answer_text = TasksExtensions.Encrypt(crypt_key, value, 128, false); }
        }
    }
}