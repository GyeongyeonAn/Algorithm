using System;
using System.Collections.Generic;

public class Data
{
    public string name = "";
    public int send = 0;
    public int receipt = 0;
    public int result = 0;
    
    public Data(string name)
    {
        this.name = name;
    }
    
    public int calPresentAmount()
    {
        return send - receipt;
    }
}

public class Solution 
{
    public List<Data> datas;
    public int[,] relation_table;
    
    public void present(string sender, string receiver)
    {
        int index1 = 0;
        int index2 = 0;
        
        for(int i=0; i<datas.Count; i++)
        {
            if(datas[i].name == sender)
            {
                index1 = i;
                datas[i].send += 1;
            }
            if(datas[i].name == receiver)
            {
                index2 = i;
                datas[i].receipt += 1;
            }
            
        }
        relation_table[index1, index2] += 1;
    }
    
    public int solution(string[] friends, string[] gifts) 
    {
        datas = new List<Data>();
        relation_table = new int[friends.Length, friends.Length];
        int answer = 0;
        
        // 프렌즈 데이터 셋팅 
        for(int i=0; i<friends.Length; i++)
        {
            Data data = new Data(friends[i]);
            datas.Add(data);
        }
        
        // 릴레이션 테이블 셋팅
        for(int i=0; i<gifts.Length; i++)
        {
            string[] word = gifts[i].Split(" ");
            present(word[0], word[1]);
        }
        
        // 릴레이션 테이블 출력
        for (int i = 0; i < friends.Length; i++)
        {
            for (int j = 0; j < friends.Length; j++)
            {
                System.Console.Write(relation_table[i, j]);
                System.Console.Write(" ");
            }
            System.Console.WriteLine("");
        }

        
        // 받는 선물 계산
        for(int i=0; i<friends.Length; i++)
        {
            for(int j=0; j<friends.Length; j++)
            {
                if(i != j)
                {
                    if(relation_table[i, j] != relation_table[j, i])
                    {
                        if(relation_table[i, j] > relation_table[j, i])
                        {
                            datas[i].result += 1;
                        }
                    }
                    else
                    {
                        int num1 = datas[i].calPresentAmount();
                        int num2 = datas[j].calPresentAmount();
                        if(num1 > num2)
                            datas[i].result += 1;
                    }
                }
            }
        }
        
        for(int i=0; i<datas.Count; i++)
        {
            answer = answer > datas[i].result ? answer : datas[i].result;
        }
        
        return answer;
    }
}